import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { FormBuilder, FormsModule, ReactiveFormsModule, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  public footballs: Football[];
  p: number = 1;
  key: string = 'name'; //set default
  reverse: boolean = false;
  
  collection: any[];
  teamsForm = this.formBuilder.group({
    name: ''
  });
  Url: string;  
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string, private formBuilder: FormBuilder) {
    this.Url = baseUrl + 'football/GetData/';
  }

  onSubmit(data): void {
    // Process checkout data here
    console.warn('Your country name has been submitted', data.name);
    if (data.name != null && data.name != '') {
      this.p = 1;
      this.http.get<Football[]>(this.Url + data.name).subscribe(result => {
        this.footballs = result;
        this.collection = result;
      }, error => console.error(error));
    }
    else {
      alert('Please enter country name!');
    }
    
  }

  sort(key) {
    this.key = key;
    this.reverse = !this.reverse;
  }
}

interface Football {
  logo: string;
  founded: string;
  city: string;
  name: string;
  venueName: number;
}
