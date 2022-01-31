﻿using OngProject.Core.Models.DTOs;
using OngProject.Entities;
using System.Threading.Tasks;

namespace OngProject.Core.Interfaces
{
    public interface ICommentsService
    {
        Task<CommentDTO> GetAll();
        Comment GetById();
        void Insert(Comment comment);
        void Update(Comment comment);
        void Delete(Comment comment);
    }
}