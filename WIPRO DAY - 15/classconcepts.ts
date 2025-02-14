class Product
{
    id:number;
    proname:string;
    proprice:number;

    constructor(id:number,proname:string,proprice:number)
    {
        this.id=id;
        this.proname=proname;
        this.proprice=proprice;
    }
    Display()
    {
        return `${this.id} ${this.proname} ${this.proprice}`;
    }
    
}
console.log(new Product(123,'Laptop',80000));
