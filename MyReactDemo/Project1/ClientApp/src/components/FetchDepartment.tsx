import * as React from 'react';
import { connect } from 'react-redux';
import { RouteComponentProps } from 'react-router';
import { Link } from 'react-router-dom';
import { ApplicationState } from '../store';
import * as DepartmentsStore from '../store/department';

// At runtime, Redux will merge together...
type DepartmentProps =
    DepartmentsStore.DepartmentsState // ... state we've requested from the Redux store
    & typeof DepartmentsStore.actionCreators // ... plus action creators we've requested
    & RouteComponentProps<{ departmentIdIndex: string }>; // ... plus incoming routing parameters


class FetchData extends React.PureComponent<DepartmentProps> {
    // This method is called when the component is first added to the document
    public componentDidMount() {
        this.ensureDataFetched();
    }

    // This method is called when the route parameters change
    public componentDidUpdate() {
        this.ensureDataFetched();
    }

    public render() {
        return (
            <React.Fragment>
                <h1 id="tabelLabel">List of Departments</h1>
                <p>This component demonstrates fetching data from the server and working with URL parameters.</p>
                {this.renderDepartmentsTable()}
                {this.renderPagination()}
            </React.Fragment>
        );
    }

    private ensureDataFetched() {
        const departmentIdIndex = parseInt(this.props.match.params.departmentIdIndex, 10) || 0;
        this.props.requestDepartments(departmentIdIndex);
    }

    private renderDepartmentsTable() {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Department ID</th>
                        <th>Department Name</th>
                    </tr>
                </thead>
                <tbody>
                    {this.props.departments.map((dept: DepartmentsStore.Department) =>
                        <tr key={dept.departmentId}>
                            <td>{dept.departmentId}</td>
                            <td>{dept.departmentName}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    private renderPagination() {
        const prevDepartmentIdIndex = (this.props.departmentIdIndex || 0) - 5;
        const nextDepartmentIdIndex = (this.props.departmentIdIndex || 0) + 5;

        return (
            <div className="d-flex justify-content-between">
                <Link className='btn btn-outline-secondary btn-sm' to={`/fetch-department/${prevDepartmentIdIndex}`}>Previous</Link>
                {this.props.isLoading && <span>Loading...</span>}
                <Link className='btn btn-outline-secondary btn-sm' to={`/fetch-department/${nextDepartmentIdIndex}`}>Next</Link>
            </div>
        );
    }
}

export default connect(
    (state: ApplicationState) => state.departments, // Selects which state properties are merged into the component's props
    DepartmentsStore.actionCreators                // Selects which action creators are merged into the component's props
)(FetchData as any); // eslint-disable-line @typescript-eslint/no-explicit-any