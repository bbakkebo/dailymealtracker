using System;
using System.Collections.Generic;
using System.Text;

namespace DailyMeal.Gateway
{
    public interface IRepository
    {
        void LoadEaters();

        void UpdateEater();

        void SaveEater();

        void DeleteEater();

        void LoadMeals();

        void UpdateMeal();

        void SaveMeal();

        void DeleteMeal();

        void LoadEater();

        void LoadMeal();

        void UpdateMeals();

        void DeleteFood();

        void LoadFoods();

        void SaveFood();

        void UpdateFoods();

        void UpdateFood();

        void UpdateDrink();

        void UpdateDrinks();

        void SaveDrink();

        void LoadDrinks();

        void DeleteDrink();
    }
}
