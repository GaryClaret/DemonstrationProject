using DemonstrationProject.Adaptors;
using DemonstrationProject.DomainObjects;
using DemonstrationProject.Models;
using DemonstrationProject.RawDataMappers;
using DemonstrationProject.UIMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemonstrationProject.BusinessLogic
{
    public class FilmShowTimeBl : IFilmShowTimeBl
    {
        private readonly IFilmShowTimeMapper _filmShowMapper;
        private readonly ICustomerDataServiceAdaptor _ds;
        private readonly IFilmShowTimeModelMapper _modelMapper;

        public FilmShowTimeBl(IFilmShowTimeMapper showTimeMapper, ICustomerDataServiceAdaptor ds, IFilmShowTimeModelMapper modelMapper)
        {
            _filmShowMapper = showTimeMapper;
            _ds = ds;
            _modelMapper = modelMapper;
        }

        public List<DomainObjects.DmFilmShowTime> ProvideFilmShowTimes(string dateOfShowings)
        {
            return _filmShowMapper.MapRawFilmShowTimeToDomain(_ds.ProvideFilmShowTimes(dateOfShowings));
        }

        public FilmHeaderModel ProvideFilmShowTimeModel(List<DmFilmShowTime> domainFilmTimesList)
        {
            var header = new FilmHeaderModel();
            var listofFilmModels = new List<FilmShowTimeModel>();

            foreach (DmFilmShowTime domainFilmTime in domainFilmTimesList)
            {
                var formattedFilmTitle = FormatFilmTitle(domainFilmTime.title, domainFilmTime.releaseYear);
                var formattedDirectors = FormatDirectors(domainFilmTime.directors);
                var formattedLongDesc = FormatLongDescription(domainFilmTime.longDescription);

                var individualFilmModel = _modelMapper.Map(formattedFilmTitle, formattedDirectors, formattedLongDesc);
                listofFilmModels.Add(individualFilmModel);
            }

            header.movies = listofFilmModels;
            return header;
        }

        private string FormatFilmTitle(string title, string year)
        {
            return title + " (" + year + ")";
        }

        private string FormatDirectors(string[] directors)
        {
            string directorLabel = string.Empty;
            int i = 0;
            
            if (directors != null) {
                foreach (string director in directors)
                {
                    i++;
                    directorLabel += director;

                    if (i > 1) {
                        directorLabel += ", ";
                    }
                }
            }  

            return directorLabel;
        }

        private string FormatLongDescription(string longDescription)
        {
            var formattedDesc = string.Empty;
            if (longDescription != null) { formattedDesc = longDescription.Replace("@", ""); }
            return formattedDesc;
        }
    }
}