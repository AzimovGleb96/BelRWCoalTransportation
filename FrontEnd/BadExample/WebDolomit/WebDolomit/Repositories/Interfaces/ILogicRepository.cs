using System;
using System.Collections.Generic;
using WebDolomit.Models;
using WebDolomit.ViewModels;

namespace WebDolomit.Repositories
{
    public interface ILogicRepository
    {
        List<DataViewModel> GetData(DateTime date);
        List<Data> GetDataForReport(DateTime date);
        bool SaveData(Data model);
        Data FindDataByID(int id);
    }
}