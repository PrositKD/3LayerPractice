using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using DAL.Repos;
using System.Collections.Generic;

namespace BLL.Services
{
    public class UserService
    {
       
public static string Getnews(int id)
        {
            
            var data = DataAccessFactory.NewsData().Get(id);
            return null;
        }

        public static List<newsDto> GetNews()
        {
            // Retrieve your News entities, assuming UserRepo.GetNews() returns a collection of News
            var newsEntities = DataAccessFactory.NewsData().Get();

            // Configure AutoMapper
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<News, newsDto>();
                // Add additional mappings if needed
            });

            // Create mapper instance
            var mapper = new Mapper(config);

            // Map the collection of entities to a collection of DTOs
            var newsDtos = mapper.Map<List<newsDto>>(newsEntities);

            return newsDtos;
        }



        public static bool CreateNews(newsDto newsDto)
        {
            // Configure AutoMapper
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<newsDto, News>(); // Map from DTO to entity
                                                // Add additional mappings if needed
            });

            // Create mapper instance
            var mapper = new Mapper(config);

            // Map the input DTO to an entity
            var newsEntity = mapper.Map<News>(newsDto);

            // Pass the mapped entity to the repository's Add method
            return DataAccessFactory.NewsData().Add(newsEntity);
        }
    }
}
