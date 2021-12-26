import { Router, ActivatedRoute } from "@angular/router";
import { NgForm } from "@angular/forms";
import { Product } from "../model/product.model";
import { ProductRepository } from "../model/product.repository";
import { Component } from "@angular/core";

@Component({
    templateUrl: "productEditor.component.html"
})
export class ProductEditorComponent {
    editing: boolean = false;
    product: any;
    constructor(private repository: ProductRepository,
        private router: Router,
        activeRoute: ActivatedRoute) {
        this.editing = activeRoute.snapshot.params["mode"] == "edit";
        if (this.editing) {
            Object.assign(this.product, repository.getProduct(activeRoute.snapshot.params["id"]));
        }
    }
    save(form: NgForm) {
        this.repository.saveProduct(this.product);
        this.router.navigateByUrl("/admin/main/products");
    }
}
