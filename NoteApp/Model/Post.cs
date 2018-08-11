﻿using System;

namespace NoteApp.Model
{
    public class Post
    {
       public int Id { get; set; }
       public DateTime DateWritten { get; set; }
       public string Title { get; set; }
       public string Body { get; set; }   
    }
}