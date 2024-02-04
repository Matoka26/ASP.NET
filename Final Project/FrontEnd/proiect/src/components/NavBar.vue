
<template>
  <div class="main">
    <header class="main-header">
      <div class="logo-text">{{ name }}</div>


      <nav class="nav-bar">
        <div class="searchBar">
          <input v-model="searchQuery" placeholder="Search..." />
          <button @click="search" class="searchButton">Search</button>
        </div>
        <router-link to="/ProfilePage" class="nav-link">
          <button class="normalButton">My Profile</button>
        </router-link>

        <router-link to="/MainPage" class="nav-link">
          <button class="normalButton">Home</button>
        </router-link>

        <router-link to="/HomePage" class="nav-link">
          <button class="logoutButton" @click="removeToken">Logout</button>
        </router-link>

      </nav>
    </header>

  </div>
</template>

<script>
import { defineProps } from 'vue';


const props = defineProps(['name']);
export default {
  name: 'NavBar',
  props: ["name"],
  data() {
    return {
      searchQuery: '',
    };
  },
  methods: {
    removeToken() {
      localStorage.removeItem('myToken');
    },
    search() {
      console.log('Searching for:', this.searchQuery);
    },
  },
};

</script>

<style scoped>

.main-header {
  background-color: #41b883;
  color: #fff;
  padding: 10px;
  display: flex;
  justify-content: space-between;
  align-items: center;
}

.logoutButton{
  font-size: large;
  border: 3px solid #f14d12;
  background: transparent;
  color: #f14d12;
  text-align: center;
  justify-content: space-between;
  display: flex;
  padding: 10px;
  margin-left: 10px;
  transition: background-color 0.3s ease;
  cursor: pointer;
}

.normalButton{
  font-size: large;
  border: 3px solid #2565b7;
  background: transparent;
  color: #2565b7;
  text-align: center;
  justify-content: space-between;
  display: flex;
  padding: 10px;
  margin-left: 10px;
  transition: background-color 0.3s ease;
  cursor: pointer;
}

.nav-bar {
  display: flex;
  margin-left: auto;
}

.normalButton:hover{
  background-color: #2565b7;
  color: black;
  border-color: black;
}

.logoutButton:hover{
  background-color: #f14d12;
  color: black;
  border-color: black;
}

.logo-text {
  font-size: 1.8em;
  font-weight: bold;
}

.nav-link {
  text-decoration: none;
}
input {
  padding: 10px;
  border: 1px solid #ccc;
  border-radius: 5px;
  outline: none;
}

.searchBar {
  display: flex;
  align-items: center;
  gap: 7px;
  margin-right: 20px;
}

.searchButton {
  padding: 10px 15px;
  border: none;
  border-radius: 5px;
  cursor: pointer;
  transition: background-color 0.3s ease;
}

.searchButton:hover {
  background-color: #2565b7;
  color: #fff;
}
</style>