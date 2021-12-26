import { NgModule } from '@angular/core';
import { ProductRepository } from './product.repository';
import { StaticDataSource } from './static.datasource';
import { Cart } from './cart.model';
import { RestDataSource } from './rest.datasource';
import { HttpClientModule } from '@angular/common/http';
import { OrderRepository } from './order.repository';
import { Order } from './order.model';
import { AuthService } from './auth.service';

@NgModule({
    imports: [HttpClientModule],
    providers: [ProductRepository, StaticDataSource, Cart,
        Order, OrderRepository,{ provide: StaticDataSource, useClass: RestDataSource }, RestDataSource, AuthService],
        exports: []
    //tells angular which classes to use as services for dependancy injection feature
    //providers: [ProductRepository, StaticDataSource, Cart]
})
export class ModelModule { }