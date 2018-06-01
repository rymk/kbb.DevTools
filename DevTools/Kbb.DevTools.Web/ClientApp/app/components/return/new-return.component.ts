import { Component, Inject } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { Http } from '@angular/http';

@Component({
    selector: 'new-return',
    templateUrl: './new-return.component.html'
})
export class NewReturnComponent {
    public doneGettingData: boolean = false;
    public returnForm: FormGroup;//TODO:create ReturnForm;
    public calculatedRefund: number;
    public itemsSummary: string[];// TODO: dont do this, need to calculate a simple summary from the clientOrder
        
    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        //http.get(baseUrl + 'api/Return').subscribe(result => {
        //    this.returns = result.json() as Return[];
        //}, error => console.error(error));

        this.returnForm = new FormGroup({
            // TODO: left off here fucking with form things...
            emailid: new FormControl("", Validators.compose([
                Validators.required,
                Validators.pattern("[^ @]*@[^ @]*")
            ])),
            //passwd: new FormControl("", this.populateOrderDetails) // TODO: do i really need/want to do it like this? learning is prob right choice. write, clean, new, sexy code lmao
        });

        this.doneGettingData = true;
    }

    populateOrderDetails(formcontrol: FormControl) {
        // TODO: make server call to get order details, or maybe they should already be attached to the orderNumberSelector?
        // TODO: how am i going to get the orderId off of this type of object?
        var test = this.returnForm;
        console.log('populate', this.returnForm);

        // TODO: validate real field(s)
        if (formcontrol.value.length < 5) {
            return { "passwd": true };
        }
        

        return false;
    }

    onClickSubmit(data: Object/*ReturnForm*/) {
        console.log("Entered data: ", data);
    }
}

//interface ReturnForm {
//    returnId: string;
//    order: ClientOrder;
//    // TODO: make the model; make this reusable and then give the dashboard a lightweight Return model
//}
