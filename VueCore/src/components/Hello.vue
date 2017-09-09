<template>
  <div class="hello">
    <h3>{{msg}}</h3>
    <v-container grid-list-xl text-xs-center>
      <v-layout row wrap>
        <v-flex xs10 offset-xs1>
          <form class="">
            <v-text-field label="Name"
                          v-model="name"
                          required></v-text-field>
            <v-text-field label="E-mail"
                          v-model="email"
                          required></v-text-field>
            <v-checkbox label="Do you agree?"
                        v-model="checkbox"
                        required></v-checkbox>

            <v-btn>submit</v-btn>
            <v-btn>clear</v-btn>
          </form>
        </v-flex>
      </v-layout>
    </v-container>
  </div>
</template>
<script>
  import axios from 'axios'

  export default {
    name: 'TestComponent',
    data() {
      return {
        name: '',
        email: '',
        checkbox: true,
        msg: 'Welcome to Your Vue.js App'
      }
    },

    created() {
      axios.get('/api/greeting').then((response) => {
        console.log(response)
        this.msg = response.data.message
      }, (error) => {
        console.log(error)
      })
    }
  }
</script>

<style scoped>
  h1, h2 {
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
</style>
