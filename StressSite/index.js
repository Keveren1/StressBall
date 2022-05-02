const baseUrl1 = "https://complimentr.com/api";
const baseUrl2 = "https://insult.mattbas.org/api/insult";
Vue.createApp({
    data() {
        return {
            Insult: null,
            Compliment: null,
        }
    },
   
    methods: {
      async helperGetFact(){
        try{
            const response = await axios.get(baseUrl1)
            this.Compliment = await response.data
            this.error = null
        } catch (ex){
            alert(ex)
        }
        },
        async helperGetFactos(){
            try{
                const response = await axios.get(baseUrl2)
                this.Insult = await response.data
                this.error = null
            } catch (ex){
                alert(ex)
            }
            }
    
    }
}).mount("#app")