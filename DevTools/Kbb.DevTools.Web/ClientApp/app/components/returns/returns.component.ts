import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'returns',
    templateUrl: './returns.component.html'
})
export class ReturnsComponent {
    public returns: Return[];

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        // TODO: it'd be nice to add a reusable layer for server comm to hande this junk.
        //  can we use <T> functions or pass types in for casting into explicit model object?
        http.get(baseUrl + 'api/Return').subscribe(result => {
            this.returns = result.json() as Return[];
        }, error => console.error(error));
    }
}