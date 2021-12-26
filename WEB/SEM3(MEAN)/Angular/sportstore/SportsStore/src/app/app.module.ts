import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { StoreModule } from './store/store.module';
import { AppComponent } from './app.component';
import { StoreComponent } from './store/store.component';
import { CartDetailComponent } from './store/cartDetail.component';
import { CheckoutComponent } from './store/checkout.component';
import { RouterModule } from '@angular/router';
import { StoreFirstGuard } from './storeFirst.guard';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AdminModule } from './admin/admin.module';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [BrowserModule, StoreModule, FormsModule, ReactiveFormsModule, AdminModule,
    RouterModule.forRoot([
      { path: 'store', component: StoreComponent },
      { path: 'cart', component: CartDetailComponent },
      { path: 'checkout', component: CheckoutComponent },
    ])],
  providers: [StoreFirstGuard],
  bootstrap: [AppComponent]
})
export class AppModule { }
