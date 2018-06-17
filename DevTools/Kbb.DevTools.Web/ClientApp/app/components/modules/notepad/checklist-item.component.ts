import { Component, Input } from '@angular/core';
import { Note } from '../../../models/modules/notepad/note.model';


@Component({
    selector: 'checklist-item',
    templateUrl: './checklist-item.component.html'
})
export class ChecklistItemComponent {
    @Input() thenote: any;
    public inEditMode: boolean = false;

    constructor() {
        console.log('thenote:', this.thenote);
    }
    console.log('thenote111:', this.thenote);
}