class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
        public int ExpectedMinutesInOven(){
            return 40;
        }
    // TODO: define the 'RemainingMinutesInOven()' method
        public int RemainingMinutesInOven(int minutesInOven){
            return 40 - minutesInOven;
        }
    // TODO: define the 'PreparationTimeInMinutes()' method
        public int PreparationTimeInMinutes(int amountOfLayers){
            return amountOfLayers * 2;
        }
    // TODO: define the 'ElapsedTimeInMinutes()' method
        public int ElapsedTimeInMinutes(int amountOfLayers, int minutesInOven){
             return (amountOfLayers * 2) + minutesInOven;   
        }
}
