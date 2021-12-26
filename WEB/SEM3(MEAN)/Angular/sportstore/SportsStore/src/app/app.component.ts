import { Component } from '@angular/core';
import { registerLocaleData } from '@angular/common';
import localeFr from '@angular/common/locales/fr';
registerLocaleData(localeFr, 'fr');
@Component({
  selector: 'app',
  template: `<router-outlet></router-outlet>`
})
export class AppComponent { }
