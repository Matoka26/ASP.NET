<template>
  <div class="profile-page">
    <NavBar name="Animal Glimpse" @search="handleSearch" />

      <div class="posts div1">
        <ul>
          <li v-for="item in items" :key="item.id">
            <Post :username="item.username" :description="item.description" :picture="item.picture" />
          </li>
        </ul>
      </div>

    </div>
</template>

<script>

import {defineComponent, onMounted, ref} from "vue";
import NavBar from "@/components/NavBar.vue";
import Post from "@/components/Post.vue";
import {foundProfile, foundUser, getFeed, getPostsOfUser} from "@/Helpers/Axios.ts";

export default defineComponent({
  components: {Post, NavBar},
  setup() {
    const items = ref([]);

    onMounted(async () => {
      try {

        items.value = await getFeed();

      } catch (error) {
        console.error("Error fetching:", error);
      }
    });
    return {items};
  },
  methods: {
    handleSearch(searchQuery) {
      console.log("Searched:", searchQuery)
      localStorage.setItem('SearchedToken', searchQuery);
      //location.reload();
      this.$router.push('/OtherProfile');
    }
  }
})
</script>

<style scoped>

.div1 {
  padding-top: 70px;
}

</style>
