import { Action, Reducer } from 'redux';
import { AppThunkAction } from '.';

// -----------------
// STATE - This defines the type of data maintained in the Redux store.

export interface DepartmentsState {
    isLoading: boolean;
    departmentIdIndex?: number;
    departments: Department[];
}

export interface Department {
    departmentId: number;
    departmentName: string;
}

// -----------------
// ACTIONS - These are serializable (hence replayable) descriptions of state transitions.
// They do not themselves have any side-effects; they just describe something that is going to happen.

interface RequestDepartmentsAction {
    type: 'REQUEST_DEPARTMENTS';
    departmentIdIndex: number;
}

interface ReceiveDepartmentsAction {
    type: 'RECEIVE_DEPARTMENTS';
    departmentIdIndex: number;
    departments: Department[];
}

// Declare a 'discriminated union' type. This guarantees that all references to 'type' properties contain one of the
// declared type strings (and not any other arbitrary string).
type KnownAction = RequestDepartmentsAction | ReceiveDepartmentsAction;

// ----------------
// ACTION CREATORS - These are functions exposed to UI components that will trigger a state transition.
// They don't directly mutate state, but they can have external side-effects (such as loading data).

export const actionCreators = {
    requestDepartments: (departmentIdIndex: number): AppThunkAction<KnownAction> => (dispatch, getState) => {
        // Only load data if it's something we don't already have (and are not already loading)
        const appState = getState();
        if (appState && appState.departments && departmentIdIndex !== appState.departments.departmentIdIndex) {
            fetch(`api/departmentsapi`)
                .then(response => response.json() as Promise<Department[]>)
                .then(data => {
                    dispatch({ type: 'RECEIVE_DEPARTMENTS', departmentIdIndex: departmentIdIndex, departments: data });
                });

            dispatch({ type: 'REQUEST_DEPARTMENTS', departmentIdIndex: departmentIdIndex });
        }
    }
};

// ----------------
// REDUCER - For a given state and action, returns the new state. To support time travel, this must not mutate the old state.

const unloadedState: DepartmentsState = { departments: [], isLoading: false };

export const reducer: Reducer<DepartmentsState> = (state: DepartmentsState | undefined, incomingAction: Action): DepartmentsState => {
    if (state === undefined) {
        return unloadedState;
    }

    const action = incomingAction as KnownAction;
    switch (action.type) {
        case 'REQUEST_DEPARTMENTS':
            return {
                departmentIdIndex: action.departmentIdIndex,
                departments: state.departments,
                isLoading: true
            };
        case 'RECEIVE_DEPARTMENTS':
            // Only accept the incoming data if it matches the most recent request. This ensures we correctly
            // handle out-of-order responses.
            if (action.departmentIdIndex === state.departmentIdIndex) {
                return {
                    departmentIdIndex: action.departmentIdIndex,
                    departments: action.departments,
                    isLoading: false
                };
            }
            break;
    }

    return state;
};