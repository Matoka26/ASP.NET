<template>
  <div class="signup-container">
    <h1>Sign Up</h1>
    <form @submit.prevent="signUp" class="signup-form">
      <div class="form-group">
        <label for="firstName" >FirstName:</label>
        <input id="firstName" v-model="firstName" required>
      </div>
      <div class="form-group">
        <label for="lastName">LastName:</label>
        <input id="lastName" v-model="lastName" required>
      </div>
      <div class="form-group">
        <label for="phoneNumber">PhoneNumber:</label>
        <input id="phoneNumber" v-model="phoneNumber" required>
      </div>
      <div class="form-group">
        <label for="userName">Username:</label>
        <input id="userName" v-model="userName" required>
      </div>
      <div class="form-group">
        <label for="email">Email:</label>
        <input type="email" id="email" v-model="email" required>
      </div>
      <div class="form-group">
        <label for="password">Password:</label>
        <input type="password" id="password" v-model="password" required>
      </div>
      <button type="submit" class="signup-button">SignUp</button>
    </form>
  </div>
</template>


<script lang="ts">
import { defineComponent, ref } from 'vue';
import router from "@/router";
import {signUp as authServiceSignUp} from "@/Helpers/Axios";

export default defineComponent({
  name: 'SignupPage',
  setup() {
    const firstName = ref('');
    const lastName = ref('');
    const phoneNumber = ref('');
    const email = ref('');
    const userName = ref('');
    const password = ref('');

    const signUp = async () => {

      await authServiceSignUp(firstName.value,lastName.value,
                              phoneNumber.value, userName.value,
                              email.value, password.value);
      console.log(userName.value);
      router.push('/Login');
    };

    return { firstName, lastName, phoneNumber, userName, email, password, signUp };
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