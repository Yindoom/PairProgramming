namespace PairProgramming
{
    public interface IRPNCalculator
    {
        void Push(int add);
        void Pop();
        int Top();
        void Clear();
        int Size();

        void Add();
        void Subtract();
        void Multiply();
        void Divide();
    }
}