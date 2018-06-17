import { Component, Input } from '@angular/core';
import { Note } from '../../../models/modules/notepad/note.model';


@Component({
    selector: 'checklist-item',
    templateUrl: './checklist-item.component.html'
})
export class ChecklistItemComponent {
    @Input() theNote: Note = new Note();
    public inEditMode: boolean = false;

    constructor() {
        console.log('thenote:', this.theNote);
    }
}