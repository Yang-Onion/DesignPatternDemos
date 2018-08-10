using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeight.Sample
{
    public class FlyWeightFactory
    {
        private Dictionary<string, FlyWeight> flyWeightDictionary = new Dictionary<string, FlyWeight>();

        public FlyWeight CreateFlyWeight(string id)
        {
            if (!flyWeightDictionary.ContainsKey(id))
            {
                ConcreteFlyWeight concreteFlyWeight = new ConcreteFlyWeight();
                flyWeightDictionary.Add(id, concreteFlyWeight);
            }

            return flyWeightDictionary[id];
        }

    }
}
