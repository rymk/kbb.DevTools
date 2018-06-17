import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';
import { Note } from '../../../models/modules/notepad/note.model';

@Component({
    selector: 'notepad',
    templateUrl: './notepad.component.html'
})
export class NotepadComponent {
    notes: Note[] = new Array(20); // TODO: change datatype
    public inEditMode: boolean = false;

    constructor() {

        // TODO: test data without backend
        for (let i = 0; i < 20; i++) {
            let temp: Note;
            temp = new Note();
            temp.noteId = 1;
            temp.checked = (i%2 == 0);
            temp.createdBy = 'me';
            temp.noteText = 'test text ' + i;
            this.notes[i] = temp;
        }
        console.log('notes:', this.notes);
    }
}