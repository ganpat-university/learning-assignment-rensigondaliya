

export class Addition {

    constructor(private x?: number, private y?: number) {
    }

    Sum() {
        console.log('Sum: ' + (this.x + this.y));
    }
}