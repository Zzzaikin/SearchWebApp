<template>
  <div class="pa-10">
    <Search v-model="searchValue"> </Search>
    <div class="mt-10">
      <pre>searchValue:{{ searchValue }}</pre>
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
            ></Card>
          </v-col>
          <v-col v-if="chunkedCards[i].length < 2">
            <v-spacer></v-spacer>
          </v-col>
        </v-row>
      </div>
      <div v-else>
        <span>Нет данных</span>
      </div>
    </div>
  </div>
</template>

<script>
import Card from "../components/Card.vue";
import Search from "../components/Search";
export default {
  name: "Home",
  data: () => ({
    searchValue: {
      text: "",
      filters: [],
    },
  }),
  computed: {
    cards() {
      //return this.$store.state.applications;
      //return [];
      return this.$store.getters.applicationsBySearchValue(this.searchValue);
    },
    chunkedCards() {
      return this.cards.chunk(2);
    },
    watch: {
      searchValue() {
        this.cards = this.$store.getters.applicationsBySearchValue(
          this.searchValue
        );
      },
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
</style>