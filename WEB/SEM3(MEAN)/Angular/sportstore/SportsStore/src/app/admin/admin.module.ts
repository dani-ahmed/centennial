import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { RouterModule } from "@angular/router";
import { AuthComponent } from "./auth.component";
import { AdminComponent } from "./admin.component";
import { ProductTableComponent } from "./productTable.component";
import { ProductEditorComponent } from "./productEditor.component";
import { OrderTableComponent } from "./orderTable.component";
import { AuthGuard } from "./auth.guard";

let routing = RouterModule.forChild([
    { path: "admin/auth", component: AuthComponent },
    {
        path: "admin/main", component: AdminComponent,canActivate: [AuthGuard],
        children: [
            { path: "products/:mode/:id", component: ProductEditorComponent },
            { path: "products/:mode", component: ProductEditorComponent },
            { path: "products", component: ProductTableComponent },
            { path: "orders", component: OrderTableComponent },
            { path: "**", redirectTo: "products" }
        ]
    }
]);
@NgModule({
    imports: [CommonModule, FormsModule, routing, FormsModule, ReactiveFormsModule],
    declarations: [AuthComponent, AdminComponent, ProductTableComponent, ProductEditorComponent, OrderTableComponent]
})
export class AdminModule { }