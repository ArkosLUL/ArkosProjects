using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media.Animation;
using System.Windows.Media;
using System.Windows.Input;

namespace kas_cg_lab1
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        { 
            InitializeComponent();
            StartRolling();
        }
        private void StartRolling()
        {
            double nRotation = 360 * 450 / 2 / Math.PI / 25;
        
            // Constant speed
            Random rnd = new Random();
            int temp = rnd.Next(4, 100);
            DoubleAnimation da = new DoubleAnimation(0, 900, TimeSpan.FromSeconds(temp));
            da.RepeatBehavior = RepeatBehavior.Forever;
            da.AutoReverse = true;
            Yoba.BeginAnimation(Canvas.LeftProperty, da);

            da = new DoubleAnimation(0, nRotation, TimeSpan.FromSeconds(temp));
            da.RepeatBehavior = RepeatBehavior.Forever;
            da.AutoReverse = true;
            yobaRotate.BeginAnimation(RotateTransform.AngleProperty, da);

            // Acceleration
            temp = rnd.Next(4, 100);
            da = new DoubleAnimation(0, 900, TimeSpan.FromSeconds(temp));
            da.AccelerationRatio = 1.0;
            da.RepeatBehavior = RepeatBehavior.Forever;
            da.AutoReverse = true;
            YobaAnime.BeginAnimation(Canvas.LeftProperty, da);

            da = new DoubleAnimation(0, nRotation, TimeSpan.FromSeconds(temp));
            da.AccelerationRatio = 1.0;
            da.RepeatBehavior = RepeatBehavior.Forever;
            da.AutoReverse = true;
            animeYobaRotate.BeginAnimation(RotateTransform.AngleProperty, da);

            // Decelaration
            temp = rnd.Next(4, 100);
            da = new DoubleAnimation(0, 900, TimeSpan.FromSeconds(temp));
            da.DecelerationRatio = 0.6;
            da.RepeatBehavior = RepeatBehavior.Forever;
            da.AutoReverse = true;
            ellipse3.BeginAnimation(Canvas.LeftProperty, da);

            da = new DoubleAnimation(0, nRotation, TimeSpan.FromSeconds(temp));
            da.DecelerationRatio = 0.6;
            da.RepeatBehavior = RepeatBehavior.Forever;
            da.AutoReverse = true;
            ellipse3Rotate.BeginAnimation(RotateTransform.AngleProperty, da);

            // Acceleration + Deceleration
            temp = rnd.Next(4, 100);
            da = new DoubleAnimation(0, 900, TimeSpan.FromSeconds(temp));
            da.DecelerationRatio = 0.6;
            da.AccelerationRatio = 0.4;
            da.RepeatBehavior = RepeatBehavior.Forever;
            da.AutoReverse = true;
            yoba4.BeginAnimation(Canvas.LeftProperty, da);

            da = new DoubleAnimation(0, nRotation, TimeSpan.FromSeconds(temp));
            da.DecelerationRatio = 0.6;
            da.AccelerationRatio = 0.4;
            da.RepeatBehavior = RepeatBehavior.Forever;
            da.AutoReverse = true;
            yoba4Rotate.BeginAnimation(RotateTransform.AngleProperty, da);
          
        }
    }
}