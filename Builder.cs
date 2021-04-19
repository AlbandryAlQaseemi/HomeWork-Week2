using System;



    class cardBuilder
    {
        private string card;

        public cardBuilder()
        {
            this.card = "";
        }

        public cardBuilder heading(string value)
        {
            this.card += value;
            return this;
        }

        public cardBuilder Subheading(string value)
        {
            this.card += value;
            return this;
        }
        public cardBuilder content(string value)
        {
            this.card += value;
            return this;
        }
        public cardBuilder date(string value)
        {
            this.card += value;
            return this;
        }

    public cardBuilder day(string value)
    {
        this.card += value;
        return this;
    }

    public cardBuilder location(string value)
    {
        this.card += value;
        return this;
    }

    public string get()
        {
            return this.card;
        }
        static void Main(string[] args)
        {
            cardBuilder c = new cardBuilder();
            string createCard = c.heading("\n\n\nCongratulation on your Graduation!\n \n")
                .Subheading("from TUWAIQ PROGRAMMING BOOTCAM \n \n")
                .content("We are glad to invite you to graduation party \nof class 2021 in Twuaiq Academy \n \n")
                .date("Date: 7 July 2021\n")
                 .day("Day: Thursday\n")
            .location("location: Riyadh\n")
                .get();
            Console.WriteLine(createCard);


        }
    }

