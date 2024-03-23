﻿namespace goaslind_mission11.Models.ViewModels
{
    public class BooksListViewModel
    {
        public IQueryable<Book> Books { get; set;}

        public PaginationInfo PaginationInfo { get; set;} = new PaginationInfo();
    }
}