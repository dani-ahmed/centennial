import { Component } from '@angular/core';
import { Cart } from '../model/cart.model';
import { registerLocaleData } from '@angular/common';
import localeFr from '@angular/common/locales/fr';
registerLocaleData(localeFr, 'fr');
@Component({
    selector: 'cart-summary',
    templateUrl: 'cartSummary.component.html'
})
export class CartSummaryComponent {
    constructor(public cart: Cart) { }
}
