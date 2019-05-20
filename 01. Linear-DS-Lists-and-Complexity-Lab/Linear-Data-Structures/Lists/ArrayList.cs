using System;

public class ArrayList<T>
{
    private T[] data;

    private const int Initial_Capacity = 2;

    public ArrayList()
    {
        this.data = new T[Initial_Capacity];
    }

    public int Count
    {
        get;

        private set;
    }

    public T this[int index]
    {
        get
        {
            if (index >= this.Count || index<0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return this.data[index];
        }

        set
        {
            if (index >= this.Count || index<0)
            {
                throw new ArgumentOutOfRangeException();
            }
            this.data[index] = value;
        }
    }

    public void Add(T item)
    {
        if (this.data.Length <= this.Count)
        {
            this.Resize();
        }
        this.data[this.Count++] = item;
    }

    private void Resize()
    {
        T[] newArray = new T[this.Count * 2];
        Array.Copy(this.data, newArray, this.Count);
        this.data = newArray;
    }

    public T RemoveAt(int index)
    {
        if (index >= this.Count || index < 0)
        {
            throw new ArgumentOutOfRangeException();
        }

        this.Count--;
        T item = this.data[index];
        for (int i = index; i < this.Count; i++)
        {
            this.data[i] = this.data[i + 1];
        }

        if (this.Count <= this.data.Length / 4)
        {
            this.Shrink();
        }
        return item;
    }

    private void Shrink()
    {
        T[] newArray = new T[this.data.Length / 2];
        Array.Copy(this.data, newArray, this.Count);
        this.data = newArray;
    }
}
