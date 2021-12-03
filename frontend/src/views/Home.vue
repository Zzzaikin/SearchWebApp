<template>
  <div class="pa-10">
    <Search> </Search>
    <div class="mt-10">
      <div v-if="chunkedCards.length">
        <v-row class="ma-0" v-for="(chunk, i) in chunkedCards" :key="i">
          <v-col v-for="(item, j) in chunkedCards[i]" :key="item.id">
            <Card
              :class="j === 1 ? 'my-4 ml-2' : 'my-4 mr-2'"
              :title="item.title"
              :completeStage="item.completeStage"
              :useCases="item.useCases"
              :certificationNeed="item.certificationNeed"
              :pilotProjectExists="item.pilotProjectExists"
            ></Card>
          </v-col>
          <v-col v-if="chunkedCards[i].length < 2">
            <v-spacer></v-spacer>
          </v-col>
          <!--  <v-col v-if="chunkedCards[i].length < 3">
            <v-spacer></v-spacer>
          </v-col> -->
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
    text: "",
  }),
  computed: {
    cards() {
      return Array.from({ length: 100 }).map((el, i) => ({
        id: i,
        title: "Название стартапа",
        completeStage: "Стадия готовности продукта",
        useCases: "Кейсы использования продукта",
        certificationNeed: "Требуется ли сертификация продукта",
        pilotProjectExists: "Наличие пилотного проекта",
      }));
      //return [];
    },
    chunkedCards() {
      return this.cards.chunk(2);
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