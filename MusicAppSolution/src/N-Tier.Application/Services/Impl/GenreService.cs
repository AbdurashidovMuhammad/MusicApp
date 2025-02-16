﻿using N_Tier.Core.DTOs.GenreDtos;
using N_Tier.Core.Entities;
using N_Tier.DataAccess.Repositories;

namespace N_Tier.Application.Services.Impl
{
    public class GenreService : IGenreService
    {
        private readonly IGenreRepository _genreRepository;

        public GenreService(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

        public async Task<GenreDto> AddGenreAsync(GenreDto genreDto)
        {
            var genre = new Genre
            {
                Name = genreDto.Name
            };

            var createdGenre = await _genreRepository.AddAsync(genre);

            return new GenreDto
            {
                Name = createdGenre.Name
            };
        }

        public async Task<IEnumerable<ResponceGenreDto>> GetAllGenresAsync()
        {
            var genres = await _genreRepository.GetAllAsync(g => true);

            return genres.Select(genre => new ResponceGenreDto
            {
                Id = genre.Id,
                Name = genre.Name
            });
        }

        public async Task<GenreDto> GetGenreAsync(Guid id)
        {
            var genre = await _genreRepository.GetFirstAsync(g => g.Id == id);

            return new GenreDto
            {
                Name = genre.Name
            };
        }
    }
}
