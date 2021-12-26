import { Injectable } from "@angular/core";
import { Cart } from "./cart.model";

@Injectable()
export class Order {
    public id: number | undefined;
    public name: string | undefined;
    public address: string | undefined;
    public city: string | undefined;
    public province: string | undefined;
    public postalCode: string | undefined;
    public country: string | undefined;
    public shipped = false;
    constructor(public cart: Cart){}

    clear(): void{
        this.id = undefined;
        this.name = this.address = this.city = undefined;
        this.province = this.postalCode = this.country = undefined;
        this.shipped = false;
        this.cart.clear();
    }
}