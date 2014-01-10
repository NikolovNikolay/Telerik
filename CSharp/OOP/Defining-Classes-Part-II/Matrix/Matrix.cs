using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Matrix<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T> // we constrain T to work with numbers only, otherwise overloading operators are easier to use
    {
        private int rows;
        private int cols;
        private T[,] matrix;

        public Matrix(int rows, int columns) 
        {
            this.rows = rows;
            this.cols = columns;
            this.matrix = new T[rows, cols];
        }

        public int Rows
        {
            get { return this.rows; }
        }

        public int Cols
        {
            get { return this.cols; }
        }

        public T this[int rowIndex, int colIndex]
        {
            get
            {
                if (rowIndex < 0 || rowIndex >= this.rows || colIndex < 0 || colIndex >= this.cols)
                {
                    throw new ArgumentOutOfRangeException("Index is out of the matrix");
                }
                else
                    return this.matrix[rowIndex, colIndex];
            }

            set
            {
                if (rowIndex < 0 || rowIndex >= this.rows || colIndex < 0 || colIndex >= this.cols)
                {
                    throw new ArgumentOutOfRangeException("Index is out of the matrix");
                }
                else
                    this.matrix[rowIndex, colIndex] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            Matrix<T> result = new Matrix<T>(matrixOne.rows, matrixOne.cols);
            if (matrixOne.rows == matrixTwo.rows && matrixOne.cols == matrixTwo.cols)
            {
                for (int rows = 0; rows < matrixOne.rows; rows++)
                {
                    for (int cols = 0; cols < matrixOne.cols; cols++)
                    {
                        result[rows, cols] = (dynamic)matrixOne[rows, cols] + (dynamic)matrixTwo[rows, cols];
                    }
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException("Matrices size inconvinience");
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            Matrix<T> result = new Matrix<T>(matrixOne.rows, matrixOne.cols);
            if (matrixOne.rows == matrixTwo.rows && matrixOne.cols == matrixTwo.cols)
            {
                for (int rows = 0; rows < matrixOne.rows; rows++)
                {
                    for (int cols = 0; cols < matrixOne.cols; cols++)
                    {
                        result[rows, cols] = (dynamic)matrixOne[rows, cols] - (dynamic)matrixTwo[rows, cols];
                    }
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException("Matrices size inconvinience");
            }

            return result;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            if (matrix == null || matrix.rows == 0 || matrix.cols == 0)
            {
                return true;
            }

            for (int row = 0; row < matrix.rows; row++)
            {
                for (int col = 0; col < matrix.cols; col++)
                {
                    if (!matrix[row, col].Equals(default(T)))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            if (matrix == null || matrix.rows == 0 || matrix.cols == 0)
            {
                return false;
            }

            for (int row = 0; row < matrix.rows; row++)
            {
                for (int col = 0; col < matrix.cols; col++)
                {
                    if (!matrix[row, col].Equals(default(T)))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
