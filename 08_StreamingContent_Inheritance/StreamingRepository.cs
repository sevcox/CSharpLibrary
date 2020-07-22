using _07_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent_Inheritance
{
    public class StreamingRepository : StreamingContentRepository
    {
        public Show GetShowByTitle(string title)
        {
            foreach(StreamingContent content in _contentDirectory)
            {
                if(content.Title.ToLower() == title.ToLower() && content.GetType() == typeof(Show))
                {
                    return (Show)content;
                }
            }
            return null;
        }

        public Movie GetMovieByTitle(string title)
        {
            foreach(StreamingContent content in _contentDirectory)
            {
                if(content.Title.ToLower() == title.ToLower() && content is Movie) //content is Movie is same as content.GetType() == typeof(Movie))
                {
                    return (Movie)content;
                }
            }
            return null;
        }

        public List<Show> GetAllShows()
        {
            List<Show> allShows = new List<Show>();
            foreach(StreamingContent content in _contentDirectory)
            {
                if(content is Show)
                {
                    allShows.Add((Show)content);
                }
            }
            return allShows;
        }

        public List<Movie> GetAllMovies()
        {
            List<Movie> allMovies = new List<Movie>();
            foreach(StreamingContent content in _contentDirectory)
            {
                if(content is Movie)
                {
                    allMovies.Add((Movie)content);
                }
            }
            return allMovies;
        }

        //Get by other parameters


        //Get by RunTime/AverageRunTime
        public List<Movie> GetMovieByRunTime (double runTime)
        {
            List<Movie> moviesByRunTime = new List<Movie>();
            foreach(StreamingContent content in _contentDirectory)
            {
                Movie contentOfTypeMovie = (Movie)content;
                if (content is Movie && contentOfTypeMovie.RunTime == runTime)
                {
                    moviesByRunTime.Add(contentOfTypeMovie);
                }
                return moviesByRunTime;
            }
            return null;
        }

        //Get Shows with over x episodes
        public List<Show> GetShowsByEpisodeCount (int episodeCount)
        {
            List<Show> showsByEpisodeCount = new List<Show>();
            foreach(StreamingContent content in _contentDirectory)
            {
                Show contentOfTypeShow = (Show)content;
                if(content is Show && contentOfTypeShow.EpisodeCount >= episodeCount)
                {
                    showsByEpisodeCount.Add(contentOfTypeShow);
                }
                return showsByEpisodeCount;
            }
            return null;
        }

        //Get Shows/Movie By Rating
        public List<Movie> GetMoviesByRating (MaturityRating rating)
        {
            List<Movie> moviesByRating = new List<Movie>();
            foreach(StreamingContent content in _contentDirectory)
            {
                if(content is Movie && content.MaturityRating == rating)
                {
                    moviesByRating.Add((Movie)content);
                }
                return moviesByRating;
            }
            return null;
        }





    }
}
