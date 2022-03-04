using LiveGame.MyCode.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveGame.MyCode.Calendar.Logic
{
    public class CalendarHabitManager
    {
        private string _path = @"C:\Users\pkubo\OneDrive\Dokumenty\GitHub\_Files\LiveGame\Habits\Habits.json";

        public void StartManagingHabits()
        {
            Task task1 = Task.Run(() => _managingHabits());
        }

        private void _managingHabits()
        {
            const int time_30min_in_ms = 30*60*1000;
            const int time_300ms = 300;
            bool Modified = true;
            List<ModelHabit> habitsList = new List<ModelHabit>();

            while (true)
            {
                habitsList.Clear();

                if (Modified)
                {
                    _makeHabitsFileIfDoesntExist();
                    string jsonData = System.IO.File.ReadAllText(_path);
                    jsonData = jsonData.Replace("\r\n", string.Empty);
                    habitsList = JsonConvert.DeserializeObject<List<ModelHabit>>(jsonData) ?? new List<ModelHabit>();
                }
                for (int i = 0; i < habitsList.Count; i++)
                {
                    if (habitsList[i].StartTime < DateTime.Now)
                    {
                        Form_HabitRemainder form = new Form_HabitRemainder();
                        form.TextBox.Text = habitsList[i].Message;
                        form.Show();

                        while (form.SelectedAnswer == 0)
                        {
                            Thread.Sleep(time_300ms);
                            Application.DoEvents();
                        }
                        if (form.SelectedAnswer == 1)
                        {
                            ModelHabit tmp = habitsList[i];
                            _increaseHabitStartTime(ref tmp);
                        }
                        form.Close();
                        Modified = true;
                    }
                }
                if (Modified && habitsList.Count > 0)
                {
                    string jsonData = JsonConvert.SerializeObject(habitsList);
                    System.IO.File.WriteAllText(_path, jsonData);
                    Modified = false;
                }

                Thread.Sleep(time_30min_in_ms);
            }
        }

        private void _waitForAnsware()
        {

        }
        private void _increaseHabitStartTime(ref ModelHabit habit)
        {
            if (habit.Frequency == "Daily")
            {
                habit.StartTime = habit.StartTime.AddDays(1);
                return;
            }
            if (habit.Frequency == "Weekly")
            {
                habit.StartTime = habit.StartTime.AddDays(7);
                return;
            }
            if (habit.Frequency == "Every 3 days")
            {
                habit.StartTime = habit.StartTime.AddDays(3);
                return;
            }
            throw new Exception("CalendarHabitManager -> _increaseHabitStartTime()");
        }
        public void AddHabit(ModelHabit model)
        {
            _makeHabitsFileIfDoesntExist();
            string jsonData = System.IO.File.ReadAllText(_path);
            List<ModelHabit> habitsList = JsonConvert.DeserializeObject<List<ModelHabit>>(jsonData) ?? new List<ModelHabit>();
            habitsList.Add(model);

            jsonData = JsonConvert.SerializeObject(habitsList);
            System.IO.File.WriteAllText(_path, jsonData);
        }

        private void _makeHabitsFileIfDoesntExist()
        {
            if (!File.Exists(_path))
            {
                using (var aaa = File.Create(_path))
                {
                    aaa.Close();
                }
            }
        }
    }
}
