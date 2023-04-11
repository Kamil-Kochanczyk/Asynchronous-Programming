using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.Threading;

namespace Asynchronous_Programming
{
    public partial class Menu : Form
    {
        private static Enemy[] enemies =
        {
            new Enemy("Green Goblin", (int)(Math.Pow(10, 8))),
            new Enemy("Doctor Octopus", (int)(Math.Pow(10, 8))),
            new Enemy("New Goblin", (int)(Math.Pow(10, 8))),
            new Enemy("Sandman", (int)(Math.Pow(10, 8))),
            new Enemy("Venom", (int)(Math.Pow(10, 8))),
            new Enemy("Lizard", (int)(Math.Pow(10, 8))),
            new Enemy("Electro", (int)(Math.Pow(10, 8)))
        };

        public Menu()
        {
            InitializeComponent();
        }

        private void ShowProperties(object obj)
        {
            Type objType = obj.GetType();
            List<PropertyInfo> properties = objType.GetProperties().ToList();

            foreach (PropertyInfo property in properties)
            {
                Output.Text += $"{property.Name}: {property.GetValue(obj)}\n";
            }
        }

        private void Fight()
        {
            Output.Text = String.Empty;

            List<Enemy> enemiesToFight = enemies.ToList();

            foreach (Enemy enemy in enemiesToFight)
            {
                Enemy defeatedEnemy = enemy.Defeat();
                ShowProperties(defeatedEnemy);
                Output.Text += Environment.NewLine;
            }
        }

        private async Task FightAsync()
        {
            Output.Text = String.Empty;

            List<Enemy> enemiesToFight = enemies.ToList();

            foreach (Enemy enemy in enemiesToFight)
            {
                Enemy defeatedEnemy = await Task.Run(() => enemy.Defeat());
                ShowProperties(defeatedEnemy);
                Output.Text += Environment.NewLine;
            }
        }

        private async Task FightParallelAsync()
        {
            Output.Text = String.Empty;

            List<Enemy> enemiesToFight = enemies.ToList();
            var tasks = new List<Task<Enemy>>();

            foreach (Enemy enemy in enemiesToFight)
            {
                Task<Enemy> fightEnemy = new Task<Enemy>(() => enemy.Defeat());
                tasks.Add(fightEnemy);
                fightEnemy.Start();
            }

            var results = await Task.WhenAll(tasks);

            foreach (var item in results)
            {
                ShowProperties(item);
                Output.Text += Environment.NewLine;
            }
        }

        private void SyncOption_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Fight();
            stopwatch.Stop();
            Output.Text += $"Total fighting time: {stopwatch.ElapsedMilliseconds} ms.";
        }

        private async void AsyncOption_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            await FightAsync();
            stopwatch.Stop();
            Output.Text += $"Total fighting time: {stopwatch.ElapsedMilliseconds} ms.";
        }

        private async void ParallelAsyncOption_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            await FightParallelAsync();
            stopwatch.Stop();
            Output.Text += $"Total fighting time: {stopwatch.ElapsedMilliseconds} ms.";
        }
    }
}