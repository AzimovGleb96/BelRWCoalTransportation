using NLog;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WebDolomit.DAL;
using WebDolomit.Models;
using WebDolomit.ViewModels;

namespace WebDolomit.Repositories
{
    public class EFLogicRepository : ILogicRepository
    {
        private PrimaryContext _context;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public EFLogicRepository(PrimaryContext context)
        {
            _context = context;
        }
        // для просмотра конвертируем модель
        public List<DataViewModel> GetData(DateTime date)
        {
            List<Data> results = _context.DataOnWagons.Where(x => x.Date.Year == date.Year &&
            x.Date.Month == date.Month).OrderBy(x => x.Date).ToList();

            List<DataViewModel> resultsVM = new List<DataViewModel>();
            foreach (var i in results)
            {
                DataViewModel temp = new DataViewModel
                {
                    ID = i.ID,
                    Date = i.Date.ToShortDateString(),
                    CementDeclaredWagons = i.CementDeclaredWagons,
                    CementActuallyWagons = i.CementActuallyWagons,
                    CementDifferenceWagons = i.CementDifferenceWagons,

                    HPBchDeclaredWagons = i.HPBchDeclaredWagons,
                    HPBchActuallyWagons = i.HPBchActuallyWagons,
                    HPBchDifferenceWagons = i.HPBchDifferenceWagons,

                    HPUzDeclaredWagons = i.HPUzDeclaredWagons,
                    HPUzActuallyWagons = i.HPUzActuallyWagons,
                    HPUzDifferenceWagons = i.HPUzDifferenceWagons,

                    HPRfDeclaredWagons = i.HPRfDeclaredWagons,
                    HPRfActuallyWagons = i.HPRfActuallyWagons,
                    HPRfDifferenceWagons = i.HPRfDifferenceWagons,

                    PVCoordinatedWagons = i.PVCoordinatedWagons,
                    PVDeclaredWagons = i.PVDeclaredWagons,
                    PVLoadedWagons = i.PVLoadedWagons,
                    PVDifferenceWagons = i.PVDifferenceWagons,
                    PVBalanceWagons = i.PVBalanceWagons,
                    PVAverageDailyWagons = i.PVAverageDailyWagons,

                    HPCoordinatedWagons = i.HPCoordinatedWagons,
                    HPLoadedWagons = i.HPLoadedWagons,
                    HPBalanceWagons = i.HPBalanceWagons,
                    HPAverageDailyWagons = i.HPAverageDailyWagons
                };
                resultsVM.Add(temp);
            }

            var sumResults = results
                 .Select(g => new DataViewModel
                 {
                     ID = results.LastOrDefault().ID + 1,
                     Date = "Всего за " + results.Max(c => c.Date).Day + " дней",
                     CementDeclaredWagons = results.Sum(c => c.CementDeclaredWagons),
                     CementActuallyWagons = results.Sum(c => c.CementActuallyWagons),
                     CementDifferenceWagons = results.Sum(c => c.CementDifferenceWagons),

                     HPBchDeclaredWagons = results.Sum(c => c.HPBchDeclaredWagons),
                     HPBchActuallyWagons = results.Sum(c => c.HPBchActuallyWagons),
                     HPBchDifferenceWagons = results.Sum(c => c.HPBchDifferenceWagons),

                     HPUzDeclaredWagons = results.Sum(c => c.HPUzDeclaredWagons),
                     HPUzActuallyWagons = results.Sum(c => c.HPUzActuallyWagons),
                     HPUzDifferenceWagons = results.Sum(c => c.HPUzDifferenceWagons),

                     HPRfDeclaredWagons = results.Sum(c => c.HPRfDeclaredWagons),
                     HPRfActuallyWagons = results.Sum(c => c.HPRfActuallyWagons),
                     HPRfDifferenceWagons = results.Sum(c => c.HPRfDifferenceWagons),

                     //PVCoordinatedWagons = results.Sum(c => c.PVCoordinatedWagons),
                     PVDeclaredWagons = results.Sum(c => c.PVDeclaredWagons),
                     PVLoadedWagons = results.Sum(c => c.PVLoadedWagons),
                     PVDifferenceWagons = results.Sum(c => c.PVDifferenceWagons),
                    // PVBalanceWagons = results.Sum(c => c.PVBalanceWagons),
                    // PVAverageDailyWagons = results.Sum(c => c.PVAverageDailyWagons),

                    // HPCoordinatedWagons = results.Sum(c => c.HPCoordinatedWagons),
                     HPLoadedWagons = results.Sum(c => c.HPLoadedWagons),
                    // HPBalanceWagons = results.Sum(c => c.HPBalanceWagons),
                     //HPAverageDailyWagons = results.Sum(c => c.HPAverageDailyWagons)
                 }).ToList().FirstOrDefault();
            resultsVM.Add(sumResults);

            return resultsVM;
        }

        public bool SaveData(Data model)
        {
            try
            {
                if (model.ID == 0)
                    _context.DataOnWagons.Add(model);
                else
                    _context.Entry(model).State = EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                logger.Error($"{ex.StackTrace} {ex.Message}");
                return false;
            }
        }

        public Data FindDataByID(int id)
        {
            try
            {
                Data model = _context.DataOnWagons.Find(id);
                return model;
            }
            catch (Exception ex)
            {
                logger.Error($"{ex.StackTrace} {ex.Message}");
                return null;
            }
        }

        public List<Data> GetDataForReport(DateTime date)
        {
            List<Data> results = _context.DataOnWagons.Where(x => x.Date.Year == date.Year &&
            x.Date.Month == date.Month).OrderBy(x => x.Date).ToList();
            return results;
        }

    }
}