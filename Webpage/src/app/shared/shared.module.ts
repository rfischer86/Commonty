import { NgModule } from '@angular/core';
import { FlexLayoutModule } from '@angular/flex-layout';
import { MatIconModule } from '@angular/material/icon';
import { CommonModule } from '@angular/common';
import { FooterComponent } from './components/footer/footer.component';
import { HeaderComponent } from './components/header/header.component';
import { SidenavComponent } from './components/sidenav/sidenav.component';
import { TitleComponent } from './components/title/title.component';
import { ButtonComponent } from './components/button/button.component';
import { BodyComponent } from './components/body/body.component';
import { DOMService } from './services/DOM/dom-element.service';
import { AppComponent } from '../app.component';
import { SidenavItemComponent } from './components/sidenav/sidenavItem/sidenavItem.component';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { SidenavItemService } from './components/sidenav/sidenavItem/sidenavItem.service';
import { ArcordeonComponent } from './components/arcordeon/arcordeon.component';
import { OverlayComponent } from './components/overlay/overlay.component';
import { NoteComponent } from './components/note/note.component';
import { MatProgressBarModule } from '@angular/material/progress-bar';
import { LoginDialogComponent } from './components/dialog/login/login';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations:
  [
    FooterComponent,
    HeaderComponent,
    SidenavComponent,
    TitleComponent,
    ButtonComponent,
    BodyComponent,
    SidenavItemComponent,
    ArcordeonComponent,
    OverlayComponent,
    NoteComponent,
    LoginDialogComponent
  ],
  imports: [
    CommonModule,
    FlexLayoutModule,
    MatIconModule,
    MatProgressBarModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,,
  ],
  exports:[
    FooterComponent,
    HeaderComponent,
    SidenavComponent,
    TitleComponent,
    ButtonComponent,
    BodyComponent,
    OverlayComponent,
    ArcordeonComponent,
    NoteComponent,
    LoginDialogComponent
  ],
  providers: [
    DOMService,
    HttpClient,
    SidenavItemService,
  ],
  bootstrap: [AppComponent]
})
export class SharedModule { }
