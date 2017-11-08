namespace Exercise_190
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows;
    using System.Windows.Media;
    using System.Windows.Shapes;

    public partial class MainWindow : Window
    {
        private const int size = 500;
        private static readonly Random rnd = new Random();

        private static readonly MathLine[] testLines1 =
        {
            new MathLine(new Point(0, 0), new Point(size, size)),
            new MathLine(new Point(0, size / 2), new Point(size, size / 2)),
            new MathLine(new Point(0, size), new Point(size, 0)),
            new MathLine(new Point(size / 2, 0), new Point(size / 2, size))
        };

        private List<MathLine> lines;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Draw(int lines)
        {
            Canvas.Children.Clear();
            this.lines = new List<MathLine>();
            for (var i = 0; i < lines; i++)
            {
                Point start = new Point(), end = new Point();

                var startside = rnd.Next(0, 4);
                switch (startside)
                {
                    case 0: //links
                        start = new Point(0, rnd.Next(0, size + 1));
                        break;

                    case 1: //oben
                        start = new Point(rnd.Next(0, size + 1), 0);
                        break;

                    case 2: //rechts
                        start = new Point(size, rnd.Next(0, size + 1));
                        break;

                    case 3: //unten
                        start = new Point(rnd.Next(0, size + 1), size);
                        break;
                    default:
                        break;
                }

                var endside = startside;
                while (endside == startside)
                {
                    endside = rnd.Next(0, 4);
                }
                switch (endside)
                {
                    case 0: //links
                        end = new Point(0, rnd.Next(0, size + 1));
                        break;

                    case 1: //oben
                        end = new Point(rnd.Next(0, size + 1), 0);
                        break;

                    case 2: //rechts
                        end = new Point(size, rnd.Next(0, size + 1));
                        break;

                    case 3: //unten
                        end = new Point(rnd.Next(0, size + 1), size);
                        break;
                    default:
                        break;
                }

                var ml = new MathLine(start, end); //testLines1[i];
                var l = new Line
                {
                    X1 = ml.Start.X,
                    Y1 = ml.Start.Y,
                    X2 = ml.End.X,
                    Y2 = ml.End.Y,

                    Stroke = Brushes.GreenYellow,
                    StrokeThickness = 2
                };
                this.lines.Add(ml);
                Canvas.Children.Add(l);
            }
        }

        private void CountSegments()
        {
            IEnumerable<Point> intersections = GetIntersections();
            var segments = lines.Count + 1 + intersections.Count();

            MessageBox.Show($"{segments} Segmente gefunden");
        }

        private IEnumerable<Point> GetIntersections()
        {
            List<MathLine> used = new List<MathLine>();
            List<Intersection> result = new List<Intersection>();
            foreach (var line in lines)
            {
                used.Add(line);
                IEnumerable<Intersection> intersections = from l in lines.Except(used)
                    let i = MathLine.GetIntersection(line, l)
                    where i != null
                    let p = i.Point
                    where p.X >= 0 && p.Y >= 0 && p.X <= size && p.Y <= size
                    select i;
                foreach (var i in intersections)
                {
                    if (!result.Contains(i))
                    {
                        result.Add(i);
                        yield return i;
                    }
                }
            }
        }

        private void ButtonDraw_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(TextBoxLines.Text, out var l) && l > 0)
            {
                Draw(l);
            }
        }

        private void ButtoCount_Click(object sender, RoutedEventArgs e)
        {
            CountSegments();
        }
    }

    public class MathLine
    {
        public MathLine(Point start, Point end)
        {
            Start = start;
            End = end;
        }

        public Point Start { get; }
        public Point End { get; }

        private double M => (End - Start).Y / (End - Start).X;
        private double B => Start.Y - M * Start.X;

        public static Intersection GetIntersection(MathLine g, MathLine h)
        {
            var mg = g.M;
            var bg = g.B;

            var mh = h.M;
            var bh = h.B;

            if (mh == mg)
            {
                return null; //new Point(-1, -1);
            }
            if (double.IsInfinity(g.M))
            {
                return new Intersection(new Point(g.Start.X, g.Start.X * h.M + h.B), g, h);
            }
            if (double.IsInfinity(h.M))
            {
                return new Intersection(new Point(h.Start.X, h.Start.X * g.M + g.B), g, h);
            }

            var x = (bh - bg) / (mg - mh);
            var y = mg * x + bg;

            return new Intersection(new Point(x, y), g, h);
        }
    }

    public class Intersection
    {
        public Intersection(Point p, MathLine l1, MathLine l2)
        {
            Point = p;
            FirstLine = l1;
            SecondLine = l2;
        }

        public Point Point { get; }
        private MathLine FirstLine { get; }
        private MathLine SecondLine { get; }

        public override bool Equals(object obj)
        {
            var i = (Intersection) obj;

            return i != null && Point == i.Point && (FirstLine == i.FirstLine || FirstLine == i.SecondLine);
        }

        public override int GetHashCode()
        {
            var hash = 13;
            hash = hash * 7 + Point.GetHashCode();
            hash = hash * 7 + FirstLine.GetHashCode() + SecondLine.GetHashCode();
            return hash;
        }

        public static implicit operator Point(Intersection v)
        {
            return v.Point;
        }
    }
}