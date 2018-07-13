﻿using MyShop.Data.Infrastructure;
using MyShop.Model.Models;

namespace MyShop.Data.Repository
{
    public interface ITagRepository
    {
    }

    public class TagRepository : RepositoryBase<Tag>, ITagRepository
    {
        public TagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}