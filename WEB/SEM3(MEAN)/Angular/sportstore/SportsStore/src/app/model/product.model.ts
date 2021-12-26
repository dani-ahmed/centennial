export class Product {
    //constructor with optional (?) arguments
    constructor(
        public id: number,
        public name: string,
        public category: string,
        public description: string,
        public price: number) { }
}