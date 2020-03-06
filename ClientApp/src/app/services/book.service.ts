import { Injectable } from '@angular/core';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Book } from '../interfaces/book';
@Injectable({
  providedIn: 'root'
})
export class BookService {
  baseURL: string = "api/Books";
  constructor(private http: HttpClient) { }

  getAllBooks() {
    return this.http.get<Book[]>(this.baseURL+"/Get");
  }

  addBook(book: Book) {
    return this.http.post(this.baseURL + "/AddBook/", book);
  }

  getBookById(id: number) {
    return this.http.get<Book>(this.baseURL + "/SingleBook/" + id);
  }

  updateBook(book: Book) {
    return this.http.put(this.baseURL + "/UpdateBook/" + book.id, book);
  }
  deleteBook(id: number) {
    return this.http.delete(this.baseURL + "/DeleteBook/" + id);
  }
}
