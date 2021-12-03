<template>
  <div class="pa-10">
    <Search v-model="searchValue"> </Search>
    <div class="mt-10">
      <div v-if="!loading">
        <div v-if="chunkedCards.length">
          <v-row class="ma-0" v-for="(chunk, i) in chunkedCards" :key="i">
            <v-col v-for="(item, j) in chunkedCards[i]" :key="item.id">
              <Card
                :class="j === 1 ? 'my-4 ml-2' : 'my-4 mr-2'"
                :id="item.id"
                :title="item.title"
                :completeStage="item.completeStage"
                :useCases="item.useCases"
                :certificationNeed="item.certificationNeed"
                :pilotProjectExists="item.pilotProjectExists"
                :productBenefits="item.productBenefits"
                :shortDescription="item.shortDescription"
                :subject="item.subject"
                :technology="item.technology"
                :imageSrc="item.imageSrc"
              ></Card>
            </v-col>
            <v-col v-if="chunkedCards[i].length < 2">
              <v-spacer></v-spacer>
            </v-col>
          </v-row>
        </div>
        <div v-else>
          <div style="display: flex; flex-direction: column">
            <span>По вашему запросу ничего не найдено.</span>
            <a href="/request">Оставить заявку</a>
          </div>
        </div>
      </div>
      <div v-else>
        <div class="spinner-wrapper">
          <v-progress-circular
            indeterminate
            color="primary"
          ></v-progress-circular>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import Card from "../components/Card.vue";
import Search from "../components/Search";
function sleep(ms) {
  return new Promise((resolve) => setTimeout(resolve, ms));
}
export default {
  name: "Home",
  data: () => ({
    cards: [],
    loading: false,
    searchValue: {
      text: "",
      filters: [],
    },
  }),
  computed: {
    chunkedCards() {
      return this.cards.length > 0 ? this.cards.chunk(2) : [];
    },
  },
  watch: {
    async searchValue() {
      this.loading = true;
      await sleep(800);
      this.cards = this.$store.getters.applicationsBySearchValue(
        this.searchValue
      );
      this.loading = false;
    },
  },
  components: {
    Search,
    Card,
  },
};
</script>
<style scoped>
.col {
  padding: 0 !important;
}
.spinner-wrapper {
  display: flex;
  justify-content: center;
  align-items: center;
}
</style>