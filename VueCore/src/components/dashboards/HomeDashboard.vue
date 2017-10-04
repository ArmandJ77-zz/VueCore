<template>
  <div>
    <v-container fluid fill-height>
      <v-layout row wrap>
        <v-flex xs12 offset-lg3 offset-sm4>
          <h3>{{ header }}</h3>
          <v-divider></v-divider>
          <div class="container-spacer_m"></div>
        </v-flex>
        <counter-component></counter-component>
        <v-flex xs12 offset-lg3 offset-sm4>
          <grid-component></grid-component>
        </v-flex>
      </v-layout>
    </v-container>
  </div>
</template>

<script>
import GridComponent from '../clients/GridComponent';
import CounterComponent from '../clients/CounterComponent'
export default {
  components: {
    'counter-component': CounterComponent,
    'grid-component': GridComponent
  },
  data() {
    return {
      header: 'Dashboard Component'
    }
  },
  methods: {
    GoToClient() {
      console.log("Route click");
      this.$router.push("/client");
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h1,
h2 {
  font-weight: normal;
}

ul {
  list-style-type: none;
  padding: 0;
}

li {
  display: inline-block;
  margin: 0 10px;
}

a {
  color: #42b983;
}

.container-spacer_m {
  height: 5vh;
}
</style>
