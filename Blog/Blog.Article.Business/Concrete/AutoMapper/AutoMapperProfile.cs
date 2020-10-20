using AutoMapper;
using Blog.Article.Business.Concrete.AutoMapper.Dtos.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blog.Article.Business.Concrete.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Article.Entities.Concrete.Article, ArticleListForDto>()
            .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category.Name));

            CreateMap<Article.Entities.Concrete.Article, ArticleDto>()
            .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category.Name));

            CreateMap<ArticleAddForDto, Article.Entities.Concrete.Article>();
            CreateMap<ArticleUpdateForDto, Article.Entities.Concrete.Article>();
        }
    }
}
