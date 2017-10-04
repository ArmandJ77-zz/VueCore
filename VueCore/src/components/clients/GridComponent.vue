<template>
  <div>
    <br>
    <h3>{{ComponentHeader}}</h3>
    <br/>
    <v-data-table v-bind:headers="headers" v-bind:items="items" v-bind:search="search" v-bind:pagination.sync="pagination" hide-actions class="elevation-1">
      <template slot="headerCell" scope="props">
        <span v-tooltip:bottom="{ 'html': props.header.text }">
          {{ props.header.text }}
        </span>
      </template>
      <template slot="items" scope="props">
        <td>{{ props.item.Name }}</td>
        <td class="text-xs-right">{{ props.item.LastName }}</td>
        <td class="text-xs-right">{{ props.item.Email }}</td>
      </template>
    </v-data-table>
    <div class="text-xs-center pt-2">
      <v-pagination v-model="pagination.page" :length="pages"></v-pagination>
    </div>
  </div>
</template>

<script>
import axios from 'axios';
export default {
  data: () => ({
    ComponentHeader: "Clients",
    search: '',
    pagination: {},
    selected: [],
    headers: [
      {
        text: 'Name',
        align: 'left',
        sorable: false,
        value: 'Name'
      },
      { text: 'Last Name', value: 'LastName' },
      { text: 'E-mail', value: 'Email' },
    ],
    items: []
  }),
  computed: {
    pages() {
      return this.pagination.rowsPerPage ? Math.ceil(this.items.length / this.pagination.rowsPerPage) : 0
    }
  },
  created() {
    axios.get("http://localhost:8080/api/client/")
      .then(response => {
        console.log(response);
        this.items = response.data;
      })
      .catch(e => {
        console.log(e);
      })
  }
}
</script>

<style>
</style>
