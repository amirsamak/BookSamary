import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BooksComponent } from './components/books/books.component';
import { DeleteBookComponent } from './components/delete-book/delete-book.component';
import { ShowBookComponent } from './components/show-book/show-book.component';
import { NewBookComponent } from './components/new-book/new-book.component';
import { UpdateBookComponent } from './components/update-book/update-book.component';
import { BookService } from './services/book.service';
import { RouterModule } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { NavMenuComponent } from './components/nav-menu/nav-menu.component';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { ReactiveFormsModule } from '@angular/forms';
import { StoreModule } from '@ngrx/store';
import { BookReducer } from './store/book.reducer';
import { EffectsModule } from '@ngrx/effects';
import { BookEffects } from './store/book.effects';

@NgModule({
  declarations: [
    AppComponent,
    BooksComponent,
    DeleteBookComponent,
    ShowBookComponent,
    NewBookComponent,
    UpdateBookComponent,
    NavMenuComponent,
    HomeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'books', component: BooksComponent },
      { path: 'new-book', component: NewBookComponent },
      { path: 'update-book/:id', component: UpdateBookComponent },
      { path: 'delete-book/:id', component: DeleteBookComponent },
      { path: 'show-book/:id', component: ShowBookComponent }
    ]),
    HttpClientModule,
    ReactiveFormsModule,
    StoreModule.forRoot({a: BookReducer}),
    EffectsModule.forRoot([BookEffects])
  ],
  providers: [BookService, HttpClientModule],
  bootstrap: [AppComponent]
})
export class AppModule { }
