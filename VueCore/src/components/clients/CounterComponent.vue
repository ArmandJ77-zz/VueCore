<template>
  <v-flex xs3 offset-lg3 offset-sm4>
    <v-card class="light-blue lighten-1 white--text">
      <v-card-title primary-title>
        <div>
          <h1>{{counter}}</h1>
        </div>
      </v-card-title>
      <v-card-actions>
        <v-btn flat dark disabled>Number of clients</v-btn>
        <v-btn flat dark v-on:click="GoToClient()">View</v-btn>
      </v-card-actions>
    </v-card>
  </v-flex>
</template>

<script>
import axios from 'axios';

export default {
  data() {
    return {
      counter: 5
    }
  },
  created() {
    this.subHeading = "Client Data";
    axios.get("http://localhost:8080/api/client/counter")
      .then(response => {
        console.log(response);
        this.counter = response.data;
      })
      .catch(e => {
        console.log(e);
      })
  },
  methods: {
    GoToClient() {
      console.log("Route click");
      this.$router.push("/client");
    }
  }
}
</script>

<style>

</style>
