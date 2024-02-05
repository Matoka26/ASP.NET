<template>
  <div class="signup-container">
    <h1>Login</h1>
    <form @submit.prevent="login" class="signup-form">
      <div class="form-group">
        <label for="email">Email:</label>
        <input type="email" id="email" v-model="email" required>
      </div>
      <div class="form-group">
        <label for="password">Password:</label>
        <input type="password" id="password" v-model="password" required>
      </div>
      <button type="submit" class="signup-button">Login</button>
    </form>
  </div>
</template>

<script lang="ts">
import { defineComponent, ref } from 'vue';
import {login as authServiceLogin} from "@/Helpers/Axios";
import router from "@/router";

export default defineComponent({
  name: 'LoginPage',
  setup() {
    const email = ref('');
    const password = ref('');

    const login = async () => {
      await authServiceLogin(email.value, password.value);
      console.log(email.value, password.value);
      var token = localStorage.getItem('MyToken');
      if(token){
        await router.push('/MainPage');
      }
    };
    return { email, password, login };
  },
});
</script>


<style scoped>
.signup-container {
  max-width: 400px;
  margin: 0 auto;
  margin-top: 40px;
  padding: 20px;
  border: 1px solid #ccc;
  border-radius: 8px;
  box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
}

.signup-form {
  display: grid;
  gap: 10px;
}

.form-group {
  display: flex;
  flex-direction: column;
}

label {
  margin-bottom: 4px;
}

input {
  padding: 8px;
  border: 1px solid #ccc;
  border-radius: 4px;
}

.signup-button {
  background-color: #4caf50;
  color: white;
  border: none;
  border-radius: 4px;
  padding: 10px;
  cursor: pointer;
}

.signup-button:hover {
  background-color: #45a049;
}
</style>