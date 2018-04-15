namespace algorithms_Datastructures.HashTable
{
    using System;
    public class KeyValuePair<T>
    {
        private object _key;
        private T _value;
        public KeyValuePair(object key, T value)
        {
            this._value = value;
            this._key = key;
        }

        public object Key{get{return this._key;}}
        public T Value{get{return this._value;}}


    }
    public class MyHashTable<T>
    {
        private KeyValuePair<T>[] list;
        private int _length;
        public MyHashTable()
        {
            this.list = new KeyValuePair<T>[2];
            this._length = 0;
        }

        public double LoadFactor{get{return this._length/this.list.Length;}}

        private void Resize()
        {
            if(this.LoadFactor > 0.7)
            {
                KeyValuePair<T>[] newSet = new KeyValuePair<T>[this.list.Length*2];
                for(int i=0; i<this._length; i++){
                    newSet[i] = this.list[i];
                }
                this.list = newSet;
            }
        }

        public void Insert(object key, T value)
        {
            this._length += 1;
            this.Resize();

            int hash = Math.Abs(key.GetHashCode());
            int index = hash % this.list.Length;

            int prob = 1;
            while(this.list[index] != null)
            {
                index = (hash + prob)%this.list.Length;
                prob += 1;
            }
            this.list[index] = new KeyValuePair<T>(key, value);
        }

        public T SearchValueByKey(object key)
        {
            //Doesn't work yet, but the idea is good;)
            int hash = Math.Abs(key.GetHashCode());
            int index = hash % this.list.Length;

            int prob = 1;
            while(this.list[index] != null)
            {
                index = (hash + prob)%this.list.Length;
                prob += 1;
            }
            return this.list[index].Value;
        }

        public override string ToString()
        {
            string result = "Index  |  Key  |  Value\n";
            for(int i=0; i<this.list.Length;i++){
                if(this.list[i] != null){result += i.ToString() + " | " + this.list[i].Key + " | " + this.list[i].Value + "\n";}
                else{result += i.ToString() + "  |  NULL   |   NULL\n";}
            }
            result += "__________________";
            return result;
        }
    }
}