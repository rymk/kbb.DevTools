/// <reference path="../../../models/modules/notepad/note.model.ts" />
import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';
import { Note } from '../../../models/modules/notepad/note.model';

@Component({
    selector: 'notepad',
    templateUrl: './notepad.component.html'
})
export class NotepadComponent {
    public notes: Note[] = new Array(100); // TODO: change datatype
    public inEditMode: boolean = false;
    public note: Note = new Note();

    constructor() {
        this.note.noteId = 1;
        this.note.checked = false;
        this.note.createdBy = 'me';
        this.note.noteText = 'test text';

        for (let i = 0; i < 20; i++) {
            let temp: Note;
            temp = new Note();
            temp.noteId = 1;
            temp.checked = false;
            temp.createdBy = 'me';
            temp.noteText = 'test text ' + i;
            this.notes[i] = temp;
        }
        console.log('notes:', this.notes);
    }
}