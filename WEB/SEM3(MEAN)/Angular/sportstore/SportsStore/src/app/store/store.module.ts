import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { ModelModule } from '../model/model.module';
import { StoreComponent } from './store.component';
import { CounterDirective } from './counter.directive';
import { CartSummaryComponent } from './cartSummary.component';
import { registerLocaleData } from '@angular/common';
import localeFr from '@angular/common/locales/fr';
import { CartDetailComponent } from './cartDetail.component';
import { CheckoutComponent } from './checkout.component';
import { RouterModule } from '@angular/router';
import { OrderRepository } from '../model/order.repository';
import { AdminModule } from '../admin/admin.module';


registerLocaleData(localeFr, 'fr');
@NgModule({
    imports: [ModelModule, BrowserModule, FormsModule, RouterModule],
    declarations: [StoreComponent,
        CounterDirective,
        CartSummaryComponent,
        CartDetailComponent,
        CheckoutComponent],
    exports: [StoreComponent,
        CounterDirective,
        CartSummaryComponent,
        CartDetailComponent,
        CheckoutComponent]
})
export class StoreModule { }
