<script setup lang="ts">
import axios from '../Helpers/AxiosInstance'
import { ref } from 'vue'
import TestComponent from '@/components/TestComponent.vue'

interface ITest {
  name: string
  id: string
  dateCreated: string
  lastModified: string
}

// ======== TEST FETCHING ========
const tests = ref<ITest[]>([])
const areTestsLoaded = ref<boolean>(false)
const routeName = 'Test'

const fetchTests = async () => {
  try {
    let response = await axios.get(`${routeName}/all`)
    tests.value = response.data
    areTestsLoaded.value = true
  } catch (error) {
    console.error(error)
  }
}

fetchTests()
// ===============================
</script>

<template>
  <div v-if="areTestsLoaded">
    <TestComponent v-for="test in tests" :key="test.id" :id="test.id" :name="test.name" />
  </div>
</template>
