import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'DAY3_TASK';
  varibale = 'THIS IS OUR PROJECT';
  showtitle = false;
  cities = ['ahmedabad', 'surat', 'bhuj'];
 // isDisabled = true;

  onClick() {
    alert("button clicked");
  }
  constructor() {
    setTimeout(() => {
      this.title = "Modi";
    }, 2000)
  }
}
