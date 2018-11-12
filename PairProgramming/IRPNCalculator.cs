namespace PairProgramming
{
    public interface IRPNCalculator
    {
        //CRUD

        #region CREATE
        
        // Adds a number to the top of the stack
        void Push(double add);
        
        #endregion
        
        #region READ
        
        //Returns the top number in the stack
        double Top();
        //Returns the size of the stack
        int Size();
        
        #endregion

        #region UPDATE
        
        //Adds the two top numbers in the stack
        void Add();
        //Subtracts the second number from the first in the stack
        void Subtract();
        //Multiplies the two top numbers in the stack
        void Multiply();
        //Divide the first number with the second number in the stack
        void Divide();
        
        #endregion
        
        #region DELETE
        
        //Deletes the number at the top of the stack
        void Pop();
        //Deletes all numbers in the stack
        void Clear();
        
        #endregion

      
    }
}