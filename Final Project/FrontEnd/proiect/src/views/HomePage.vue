<template>
  <div class="home">
    <header>
      <h1>Animal Glimpse</h1>
      <p>Social media for cute animals</p>
    </header>

    <footer>
      <router-link to="/SignUp">
        <button class="homeButton">Get started!</button>
      </router-link>

      <router-link to="/Login">
        <button class="homeButton">Already have acount!</button>
      </router-link>
    </footer>
  </div>
</template>

<script>
export default {
  name: 'HomePage',
};
</script>

<style scoped>
.home {
  text-align: center;
  padding: 20px;
}

header {
  background-color: #41b883;
  color: #fff;
  width: 50vw;
  padding: 20px;
  margin: 0 auto;

}

footer {
  margin-top: 20px;
  padding: 10px;
  color: #fff;
}

.homeButton {
  text-align: center;
  margin: 5px;
}

.homeButton {
  background-color: rgb(57, 115, 215);
  border: 1px solid #5997e5;
  color: #150606;
  padding: 10px 20px;
  font-size: 16px;
  cursor: pointer;
  transition: background-color 0.5s ease;
}

.homeButton:hover {
  background-color: rgb(21, 88, 199);
  color: #000;
}
</style>
