namespace LeetCodeDay9Program1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var grid = new char[2][];

            grid[0] = new char[] { '1' };
            grid[1] = new char[] { '1' };
            //grid[2] = new char[] { '1', '0', '0', '0', '0' };
            //grid[3] = new char[] { '1', '1', '1', '1', '0' };

            Console.WriteLine(NumIslands(grid));
            Console.ReadLine();
        }

        public static int NumIslands(char[][] grid)
        {
            if (grid == null)
            {
                return 0;
            }

            var numberOfIslands = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {                        
                        MarkIslandBoundaries(grid, i, j);
                        numberOfIslands += 1;
                    }
                }
            }

            return numberOfIslands;
        }

        public static void MarkIslandBoundaries(char[][] grid, int row, int col)
        {
            var queue = new Queue<int[]>();

            queue.Enqueue(new int[] { row, col });

            while (queue.Any())
            {
                var location = queue.Dequeue();

                row = location[0];
                col = location[1];

                if (row < 0 || col < 0 || row > grid.Length - 1 || col > grid[0].Length - 1 || grid[row][col] != '1')
                {
                    continue;
                }

                grid[row][col] = '*';

                queue.Enqueue(new int[] { row + 1, col });
                queue.Enqueue(new int[] { row - 1, col });
                queue.Enqueue(new int[] { row, col + 1 });
                queue.Enqueue(new int[] { row, col - 1 });
            }
        }
    }
}